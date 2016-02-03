using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SQLStructureError.Support
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlStructureException : System.Exception
    {
        public override string Message
        {
            get { return _message; }
        }
        private string _message;

        public string DeveloperMessage { get; private set; }

        public XmlDocument XmlDoc { get; private set; }

        public SqlStructureException(System.Exception ex)
            : this(ex.Message, ex)
        {
        }

        public SqlStructureException(string message)
            : this(message, null)
        {
        }

        public SqlStructureException(string message, System.Exception ex)
            : base(message, ex)
        {
            var msg = message.TrimStart();
            if (msg.StartsWith(@"<E "))
            {
                this.XmlDoc = new XmlDocument();
                this.XmlDoc.LoadXml(msg);

                var xmlMessage = this.XmlDoc.SelectSingleNode(@"/E/@M");
                _message = (xmlMessage != null) ? xmlMessage.Value : msg;

                xmlMessage = this.XmlDoc.SelectSingleNode(@"/E/@D");
                this.DeveloperMessage = (xmlMessage == null) ? null : xmlMessage.Value;
            }
            else
            {
                _message = message.Trim();
                this.XmlDoc = null;
            }
        }
    }
}
