﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WCP_Repositories
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string PhotoPath { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Introduce { get; set; }

    }
}
