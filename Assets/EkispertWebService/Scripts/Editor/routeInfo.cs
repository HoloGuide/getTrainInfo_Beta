using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.EkispertWebService.Scripts.Editor
{
    class routeInfo
    {
        /// <summary>
        /// 時間
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Transfer Count : 乗り換え回数
        /// </summary>
        public int TCount { get; set; }

        /// <summary>
        /// 片道金額
        /// </summary>
        public int Money { get; set; }

        /// <summary>
        /// 番線
        /// </summary>
        public int TLine { get; set; }

        /// <summary>
        /// 乗り換え時間
        /// </summary>
        public string[] TransTime = new string[2];
    }
}
