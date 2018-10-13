using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.EkispertWebService.Scripts.Editor
{
    class routeInfo
    {

        /// <summary>
        /// 経路名
        /// </summary>
        public string RName { get; set; }

        /// <summary>
        /// 時間
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 出発駅名
        /// </summary>
        public string LeftSta { get; set; }

        /// <summary>
        /// 到着駅名
        /// </summary>
        public string ArriveSta { get; set; }

        /// <summary>
        /// 通過駅名
        /// </summary>
        public string PassSta { get; set; }

        /// <summary>
        /// 出発時間
        /// </summary>
        public string LeftTime { get; set; }


        /// <summary>
        /// 到着時間
        /// </summary>
        public string ArriveTime { get; set; }

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
        public string[] TLine = new string[2];

        /// <summary>
        /// 乗り換え時間
        /// </summary>
        public string[] TransTime = new string[2];
    }
}
