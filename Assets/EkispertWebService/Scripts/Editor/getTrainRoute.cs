using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using Sgml;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        string url = "";
        string html = GetHtml(url);

        XDocument document = Parse(html);
        IEnumerable<XElement> getInfo = document.XPathSelectElements("//span[@class=\"orange_txt\"]");

        foreach(XElement el in getInfo)
        {
            Debug.Log(el);
        }
        */
    }
    /*
    public static XDocument Parse(string content)
    {
        using (var reader = new StringReader(content))
        using (var sgmlReader = new SgmlReader { DocType = "HTML", CaseFolding = CaseFolding.ToLower, IgnoreDtd = true, InputStream = reader })
        {
            return XDocument.Load(sgmlReader);
        }
    }

    public string GetHtml(string url)
    {
        var req = (HttpWebRequest)WebRequest.Create(url);

        string html = "";

        using (var res = (HttpWebResponse)req.GetResponse())
        using (var resSt = res.GetResponseStream())
        using (var sr = new StreamReader(resSt, Encoding.UTF8))
        {
            // HTMLを取得する。
            html = sr.ReadToEnd();
        }

        return html;
    }
    */
}
