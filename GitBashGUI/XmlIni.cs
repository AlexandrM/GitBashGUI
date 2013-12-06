using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Text;

#if !PocketPC
using System.Data.SqlClient;
using System.Xml.XPath;
#endif

namespace ASE.Xml
{
#if ASEPUBLIC
	public class XmlIni
#else
	internal class XmlIni
#endif
	{
		#region Static

		private static string _fileNameS = "";
		public static string FileName
		{
			get
			{
				if (_fileNameS == "")
				{
#if !PocketPC
					_fileNameS = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\user.config";
#else
					_fileNameS = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\user.config";
#endif
					_fileNameS = _fileNameS.Replace(@"file:\", "");
				}
				return _fileNameS;
			}
			set
			{
				_fileNameS = value;
				_instance = null;
			}
		}

		private static XmlIni _instance = null;
		/// <summary>
		/// Instance XmlIni
		/// </summary>
		public static XmlIni Instance
		{
			get
			{
				//if (_instance == null)
					_instance = new XmlIni(_fileNameS, false);

				return _instance;
			}
			set
			{
				_instance =value;
			}
		}

		#endregion Static

		#region Constructor

		/// <summary>
		/// Constructor. Create XmlIni with file ApplicationPath\user.config
		/// </summary>
		public XmlIni()
		{
#if !PocketPC
			_fileName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\user.config";
#else
			_fileName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\user.config";
#endif
			_fileName = _fileName.Replace(@"file:\", "");
		}
		/// <summary>
		/// Constructor. Create XmlIni with file "fileName"
		/// </summary>
		/// <param name="fileName">Path to user config</param>
		public XmlIni(string fileName): this()
		{			
			if (fileName != "")
				_fileName = fileName;
		}
		/// <summary>
		/// Constructor. Create XmlIni with file "fileName"
		/// </summary>
		/// <param name="fileName">Path to user config</param>
		/// <param name="isFixed"></param>
		public XmlIni(string fileName, bool isFixed): this()
		{			
			if (fileName != "")
				_fileName = fileName;

			_fixed = isFixed;
		}

		private string _fileName = "";

		#endregion Constructor

		#region path, attribute, defaultValue

		private bool _fixed = true;
		private string _lastDocLoad = "";
		private XmlDocument _doc = null;
		private XmlDocument XmlDoc
		{
			get
			{
				if (_fixed)
				{
					if ((_doc == null) || (_lastDocLoad != _fileName))
					{
						if (_doc == null)
							_doc = new XmlDocument();
						if (File.Exists(_fileName))
						{
							_lastDocLoad = _fileName;
							_doc.Load(_fileName);
						}
					}
				}
				else
				{
					if (_doc == null)
						_doc = new XmlDocument();
					if (File.Exists(_fileName))
					{
						_doc.Load(_fileName);
					}
				}
				return _doc;
			}
		}
		/// <summary>
		/// Read string from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public string ReadString(string path, string attribute, string defaultValue)
		{
			string[] keys = path.Split('/');
			if (keys == null)
				return defaultValue;
			if (keys.Length == 0)
				return defaultValue;
			if (!File.Exists(_fileName))
				return defaultValue;

			XmlDocument doc = XmlDoc;
			//doc.Load(_fileName);
			XmlNode node = doc["ASE.Tools.XmlIni"];
			for(int i = 0; i < keys.Length; i++)
			{
				if (node == null)
					return defaultValue;
				if (keys[i] == "")
					continue;

				node = node[keys[i]];
			}

			if (node == null)
				return defaultValue;

			if (attribute == "")
				attribute = "key";

			if (attribute == "")
			{
				if (node.Value == "")
					return defaultValue;
				else
					return node.Value;
			}

			XmlAttribute attr = node.Attributes[attribute];
			if (attr == null)
				return defaultValue;

			if (attr.Value == "")
				return defaultValue;
			else
				return attr.Value;
		}
		/// <summary>
		/// Write string to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteString(string path, string attribute, string value)
		{
			string[] keys = path.Split('/');
			if (keys == null)
				return -1;
			if (keys.Length == 0)
				return -2;

			XmlDocument doc = XmlDoc;
			//if (File.Exists(_fileName))
				//doc.Load(_fileName);

			XmlNode node = doc["ASE.Tools.XmlIni"];
			if (node == null)
			{
				node = doc.CreateNode(XmlNodeType.Element, "ASE.Tools.XmlIni", "");
				doc.AppendChild(node);
			}
			for(int i = 0; i < keys.Length; i++)
			{
				if (keys[i] == "")
					continue;

				XmlNode newNode = node[keys[i]];
				if (newNode == null)
				{
					newNode = doc.CreateNode(XmlNodeType.Element, keys[i], "");
					node.AppendChild(newNode);
				}
				node = newNode;
			}
			
			if (attribute == "")
				attribute = "key";

			XmlAttribute attr = node.Attributes[attribute];
			if (attr == null)
			{
				attr = doc.CreateAttribute(attribute);
				node.Attributes.Append(attr);
			}
			attr.Value = value;

			doc.Save(_fileName);
			return 0;
		}
		/// <summary>
		/// Read int from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public int ReadInt(string path, string attribute, int defaultValue)
		{
			return int.Parse(ReadString(path, attribute, defaultValue.ToString()));
		}
		/// <summary>
		/// Write int to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteInt(string path, string attribute, int value)
		{
			return WriteString(path, attribute, value.ToString());
		}
		/// <summary>
		/// Read long from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public long ReadLong(string path, string attribute, long defaultValue)
		{
			return long.Parse(ReadString(path, attribute, defaultValue.ToString()));
		}
		/// <summary>
		/// Write long to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteLong(string path, string attribute, long value)
		{
			return WriteString(path, attribute, value.ToString());
		}
		/// <summary>
		/// Read DateTime from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public DateTime ReadDateTime(string path, string attribute, DateTime defaultValue)
		{
			return DateTime.Parse(ReadString(path, attribute, defaultValue.ToString()));
		}
		/// <summary>
		/// Write DateTime to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteDateTime(string path, string attribute, DateTime value)
		{
			return WriteString(path, attribute, value.ToString());
		}
		/// <summary>
		/// Read Boolean from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public bool ReadBoolean(string path, string attribute, bool defaultValue)
		{
			return ReadInt(path, attribute, (defaultValue) ? 1:0) == 1;
		}
		/// <summary>
		/// Write Boolean to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteBoolean(string path, string attribute, bool value)
		{
			return WriteString(path, attribute, (value) ? "1":"0");
		}		

		#endregion path, attribute, defaultValue

		#region path, defaultValue

		/// <summary>
		/// Read string from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public string ReadString(string path, string defaultValue)
		{
			return ReadString(path, "", defaultValue);
		}
		/// <summary>
		/// Write string to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteString(string path, string value)
		{
			return WriteString(path, "", value);
		}
		/// <summary>
		/// Read int from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public int ReadInt(string path, int defaultValue)
		{
			return int.Parse(ReadString(path, "", defaultValue.ToString()));
		}
		/// <summary>
		/// Write int to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteInt(string path, int value)
		{
			return WriteString(path, "", value.ToString());
		}
		/// <summary>
		/// Read long from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public long ReadLong(string path, long defaultValue)
		{
			return long.Parse(ReadString(path, defaultValue.ToString()));
		}
		/// <summary>
		/// Write long to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteLong(string path, long value)
		{
			return WriteString(path, value.ToString());
		}
		/// <summary>
		/// Read DateTime from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public DateTime ReadDateTime(string path, DateTime defaultValue)
		{
			return DateTime.Parse(ReadString(path, DateTime.MinValue.ToString()));
		}
		/// <summary>
		/// Write DateTime to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteDateTime(string path, long value)
		{
			return WriteString(path, value.ToString());
		}
		/// <summary>
		/// Read Boolean from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public bool ReadBoolean(string path, bool defaultValue)
		{
			return ReadInt(path, (defaultValue) ? 1:0) == 1;
		}
		/// <summary>
		/// Write Boolean to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public int WriteBoolean(string path, bool value)
		{
			return WriteString(path, (value) ? "1":"0");
		}		

		#endregion path, defaultValue

		#region path

		/// <summary>
		/// Read string from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or ""</returns>
		public string ReadString(string path)
		{
			return ReadString(path, "", "");
		}
		/// <summary>
		/// Read int from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or 0</returns>
		public int ReadInt(string path)
		{
			return int.Parse(ReadString(path, "", "0"));
		}
		/// <summary>
		/// Read long from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or 0</returns>
		public long ReadLong(string path)
		{
			return long.Parse(ReadString(path, "0"));
		}
		/// <summary>
		/// Read DateTime from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or DateTime.MinValue</returns>
		public DateTime ReadDateTime(string path)
		{
			return DateTime.Parse(ReadString(path, DateTime.MinValue.ToString()));
		}
		/// <summary>
		/// Read Boolean from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or DateTime.MinValue</returns>
		public bool ReadBoolean(string path)
		{
			return int.Parse(ReadString(path, "0")) == 1;
		}		

		#endregion path
	
		#region Delete

		public int Delete(string path, string attribute)
		{
			string[] keys = path.Split('/');
			if (keys == null)
				return -1;
			if (keys.Length == 0)
				return -2;
			if (!File.Exists(_fileName))
				return -3;

			XmlDocument doc = XmlDoc;
			//doc.Load(_fileName);

			XmlNode node = doc["ASE.Tools.XmlIni"];
			for(int i = 0; i < keys.Length; i++)
			{
				if (node == null)
					return -4;

				node = node[keys[i]];
			}

			if (node == null)
				return -5;

			if (attribute == "")
				attribute = "key";

			XmlAttribute attr = node.Attributes[attribute];
			if (attr == null)
				return -6;

			node.Attributes.Remove(attr);
			doc.Save(_fileName);
			
			return 0;
		}

		public int Delete(string path)
		{
			string[] keys = path.Split('/');
			if (keys == null)
				return -1;
			if (keys.Length == 0)
				return -2;
			if (!File.Exists(_fileName))
				return -3;

			XmlDocument doc = XmlDoc;
			//doc.Load(_fileName);

			XmlNode node = doc["ASE.Tools.XmlIni"];
			for(int i = 0; i < keys.Length; i++)
			{
				if (node == null)
					return -4;

				if ((i == keys.Length - 1) && (node[keys[i]] != null))
				{
					node.RemoveChild(node[keys[i]]);
					doc.Save(_fileName);
					return 0;
				}

				node = node[keys[i]];
			}

			return -5;
		}

		#endregion Delete
	
		#region GetLists

		public string[] GetPathes(string rootPath)
		{
			string[] keys = rootPath.Split('/');
			if (keys == null)
				return new string[0];
			if (!File.Exists(_fileName))
				return new string[0];

			XmlDocument doc = XmlDoc;
			//doc.Load(_fileName);

			XmlNode node = doc["ASE.Tools.XmlIni"];
			for(int i = 0; i < keys.Length; i++)
			{
				if (node == null)
					return new string[0];
				if (keys[i] == "")
					continue;

				node = node[keys[i]];
			}

			if (node == null)
				return new string[0];

			ArrayList list = new ArrayList();
			foreach (XmlNode child in node.ChildNodes)
				list.Add(child.Name);

			return (string[]) list.ToArray(typeof(string));
		}

		public string[] GetAttributes(string path)
		{
			string[] keys = path.Split('/');
			if (keys == null)
				return new string[0];
			if (!File.Exists(_fileName))
				return new string[0];

			XmlDocument doc = XmlDoc;
			//doc.Load(_fileName);

			XmlNode node = doc["ASE.Tools.XmlIni"];
			for(int i = 0; i < keys.Length; i++)
			{
				if (node == null)
					return new string[0];
				if (keys[i] == "")
					continue;

				node = node[keys[i]];
			}

			ArrayList list = new ArrayList();
			foreach (XmlAttribute item in node.Attributes)
				list.Add(item.Name);
		
			return (string[]) list.ToArray(typeof(string));
		}

		#endregion GetLists
	}

#if ASEPUBLIC
	public class XmlIniStatic
#else
	internal class XmlIniStatic
#endif
	{
		#region path, attribute, defaultValue

		/// <summary>
		/// Read string from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static string ReadString(string path, string attribute, string defaultValue)
		{
			return XmlIni.Instance.ReadString(path, attribute, defaultValue);
		}
		/// <summary>
		/// Write string to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteString(string path, string attribute, string value)
		{
			return XmlIni.Instance.WriteString(path, attribute, value);
		}
		/// <summary>
		/// Read int from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static int ReadInt(string path, string attribute, int defaultValue)
		{
			return XmlIni.Instance.ReadInt(path, attribute, defaultValue);
		}
		/// <summary>
		/// Write int to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteInt(string path, string attribute, int value)
		{
			return XmlIni.Instance.WriteString(path, attribute, value.ToString());
		}
		/// <summary>
		/// Read long from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static long ReadLong(string path, string attribute, long defaultValue)
		{
			return XmlIni.Instance.ReadLong(path, attribute, defaultValue);
		}
		/// <summary>
		/// Write long to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteLong(string path, string attribute, long value)
		{
			return XmlIni.Instance.WriteLong(path, attribute, value);
		}
		/// <summary>
		/// Read DateTime from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static DateTime ReadDateTime(string path, string attribute, DateTime defaultValue)
		{
			return XmlIni.Instance.ReadDateTime(path, attribute, defaultValue);
		}
		/// <summary>
		/// Write DateTime to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteDateTime(string path, string attribute, DateTime value)
		{
			return XmlIni.Instance.WriteDateTime(path, attribute, value);
		}
		/// <summary>
		/// Read Boolean from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static bool ReadBoolean(string path, string attribute, bool defaultValue)
		{
			return XmlIni.Instance.ReadBoolean(path, attribute, defaultValue);
		}
		/// <summary>
		/// Write Boolean to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="attribute">Attribute if need</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteBoolean(string path, string attribute, bool value)
		{
			return XmlIni.Instance.WriteBoolean(path, attribute, value);
		}

		#endregion path, attribute, defaultValue

		#region path, defaultValue

		/// <summary>
		/// Read string from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static string ReadString(string path, string defaultValue)
		{
			return XmlIni.Instance.ReadString(path, defaultValue);
		}
		/// <summary>
		/// Write string to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteString(string path, string value)
		{
			return XmlIni.Instance.WriteString(path, value);
		}
		/// <summary>
		/// Read int from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static int ReadInt(string path, int defaultValue)
		{
			return XmlIni.Instance.ReadInt(path, defaultValue);
		}
		/// <summary>
		/// Write int to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteInt(string path, int value)
		{
			return XmlIni.Instance.WriteInt(path, value);
		}
		/// <summary>
		/// Read long from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static long ReadLong(string path, long defaultValue)
		{
			return XmlIni.Instance.ReadLong(path, defaultValue);
		}
		/// <summary>
		/// Write long to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteLong(string path, long value)
		{
			return XmlIni.Instance.WriteLong(path, value);
		}
		/// <summary>
		/// Read DateTime from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static DateTime ReadDateTime(string path, DateTime defaultValue)
		{
			return XmlIni.Instance.ReadDateTime(path, defaultValue);
		}
		/// <summary>
		/// Write DateTime to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteDateTime(string path, long value)
		{
			return XmlIni.Instance.WriteDateTime(path, value);
		}
		/// <summary>
		/// Read Boolean from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="defaultValue">Value returned if path or attribute exits</param>
		/// <returns>Readed or default value</returns>
		public static bool ReadBoolean(string path, bool defaultValue)
		{
			return XmlIni.Instance.ReadBoolean(path, defaultValue);
		}
		/// <summary>
		/// Write Boolean to file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <param name="value">Value</param>
		/// <returns>0 if success</returns>
		public static int WriteBoolean(string path, bool value)
		{
			return XmlIni.Instance.WriteBoolean(path, value);
		}		

		#endregion path, defaultValue

		#region path

		/// <summary>
		/// Read string from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or ""</returns>
		public static string ReadString(string path)
		{
			return XmlIni.Instance.ReadString(path);
		}
		/// <summary>
		/// Read int from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or 0</returns>
		public static int ReadInt(string path)
		{
			return XmlIni.Instance.ReadInt(path);
		}
		/// <summary>
		/// Read long from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or 0</returns>
		public static long ReadLong(string path)
		{
			return XmlIni.Instance.ReadLong(path);
		}
		/// <summary>
		/// Read DateTime from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or DateTime.MinValue</returns>
		public static DateTime ReadDateTime(string path)
		{
			return XmlIni.Instance.ReadDateTime(path);
		}
		/// <summary>
		/// Read Boolean from file
		/// </summary>
		/// <param name="path">Key path "myOption/mySubOption"</param>
		/// <returns>Readed value or 0</returns>
		public static bool ReadBoolean(string path)
		{
			return XmlIni.Instance.ReadBoolean(path);
		}

		#endregion path

		#region Delete

		public static int Delete(string path, string attribute)
		{
			return XmlIni.Instance.Delete(path, attribute);
		}

		public static int Delete(string path)
		{
			return XmlIni.Instance.Delete(path);
		}

		#endregion Delete

		#region GetLists

		public static  string[] GetPathes(string rootPath)
		{
			return XmlIni.Instance.GetPathes(rootPath);
		}

		public static string[] GetAttributes(string path)
		{
			return XmlIni.Instance.GetAttributes(path);
		}

		#endregion GetLists
	
		public static void Refresh()
		{
			XmlIni.Instance = null;
		}
	}

#if ASEPUBLIC
	public class IniFileS
#else
    internal class IniFileS
#endif
    {
        #region path, attribute, defaultValue

        /// <summary>
        /// Read string from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="defaultValue">Value returned if path or attribute exits</param>
        /// <returns>Readed or default value</returns>
        public static string ReadString(string path, string attribute, string defaultValue)
        {
            return XmlIni.Instance.ReadString(path, attribute, defaultValue);
        }
        /// <summary>
        /// Write string to file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="value">Value</param>
        /// <returns>0 if success</returns>
        public static int WriteString(string path, string attribute, string value)
        {
            return XmlIni.Instance.WriteString(path, attribute, value);
        }
        /// <summary>
        /// Read int from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="defaultValue">Value returned if path or attribute exits</param>
        /// <returns>Readed or default value</returns>
        public static int ReadInt(string path, string attribute, int defaultValue)
        {
            return XmlIni.Instance.ReadInt(path, attribute, defaultValue);
        }
        /// <summary>
        /// Write int to file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="value">Value</param>
        /// <returns>0 if success</returns>
        public static int WriteInt(string path, string attribute, int value)
        {
            return XmlIni.Instance.WriteString(path, attribute, value.ToString());
        }
        /// <summary>
        /// Read long from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="defaultValue">Value returned if path or attribute exits</param>
        /// <returns>Readed or default value</returns>
        public static long ReadLong(string path, string attribute, long defaultValue)
        {
            return XmlIni.Instance.ReadLong(path, attribute, defaultValue);
        }
        /// <summary>
        /// Write long to file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="value">Value</param>
        /// <returns>0 if success</returns>
        public static int WriteLong(string path, string attribute, long value)
        {
            return XmlIni.Instance.WriteLong(path, attribute, value);
        }
        /// <summary>
        /// Read DateTime from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="defaultValue">Value returned if path or attribute exits</param>
        /// <returns>Readed or default value</returns>
        public static DateTime ReadDateTime(string path, string attribute, DateTime defaultValue)
        {
            return XmlIni.Instance.ReadDateTime(path, attribute, defaultValue);
        }
        /// <summary>
        /// Write DateTime to file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="value">Value</param>
        /// <returns>0 if success</returns>
        public static int WriteDateTime(string path, string attribute, DateTime value)
        {
            return XmlIni.Instance.WriteDateTime(path, attribute, value);
        }
        /// <summary>
        /// Read Boolean from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="defaultValue">Value returned if path or attribute exits</param>
        /// <returns>Readed or default value</returns>
        public static bool ReadBoolean(string path, string attribute, bool defaultValue)
        {
            return XmlIni.Instance.ReadBoolean(path, attribute, defaultValue);
        }
        /// <summary>
        /// Write Boolean to file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <param name="attribute">Attribute if need</param>
        /// <param name="value">Value</param>
        /// <returns>0 if success</returns>
        public static int WriteBoolean(string path, string attribute, bool value)
        {
            return XmlIni.Instance.WriteBoolean(path, attribute, value);
        }

        #endregion path, attribute, defaultValue

        #region path

        /// <summary>
        /// Read string from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <returns>Readed value or ""</returns>
        public static string ReadString(string path)
        {
            return XmlIni.Instance.ReadString(path);
        }
        /// <summary>
        /// Read int from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <returns>Readed value or 0</returns>
        public static int ReadInt(string path)
        {
            return XmlIni.Instance.ReadInt(path);
        }
        /// <summary>
        /// Read long from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <returns>Readed value or 0</returns>
        public static long ReadLong(string path)
        {
            return XmlIni.Instance.ReadLong(path);
        }
        /// <summary>
        /// Read DateTime from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <returns>Readed value or DateTime.MinValue</returns>
        public static DateTime ReadDateTime(string path)
        {
            return XmlIni.Instance.ReadDateTime(path);
        }
        /// <summary>
        /// Read Boolean from file
        /// </summary>
        /// <param name="path">Key path "myOption/mySubOption"</param>
        /// <returns>Readed value or 0</returns>
        public static bool ReadBoolean(string path)
        {
            return XmlIni.Instance.ReadBoolean(path);
        }

        #endregion path

        #region Delete

        public static int Delete(string path, string attribute)
        {
            return XmlIni.Instance.Delete(path, attribute);
        }

        public static int Delete(string path)
        {
            return XmlIni.Instance.Delete(path);
        }

        #endregion Delete

        #region GetLists

        public static string[] GetPathes(string rootPath)
        {
            return XmlIni.Instance.GetPathes(rootPath);
        }

        public static string[] GetAttributes(string path)
        {
            return XmlIni.Instance.GetAttributes(path);
        }

        #endregion GetLists

        public static void Refresh()
        {
            XmlIni.Instance = null;
        }
    }

#if !PocketPC
    public class Crypt
    {
        public static byte[] Encrypt(byte[] data, string password)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateEncryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);

            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();

            return ms.ToArray();
        }

        public static string Encrypt(string data, string password)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(data), password));
        }

        static public byte[] Decrypt(byte[] data, string password)
        {
            BinaryReader br = new BinaryReader(InternalDecrypt(data, password));
            return br.ReadBytes((int)br.BaseStream.Length);
        }

        static public string Decrypt(string data, string password)
        {
            CryptoStream cs = InternalDecrypt(Convert.FromBase64String(data), password);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        static CryptoStream InternalDecrypt(byte[] data, string password)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateDecryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream(data);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
        }
    }
#endif
}