﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctOceanAMModules.Entity
{
    public class Sys_PageUrlEntity
    {
        /// <summary>
        /// 页面Id
        /// </summary>
        public int PageId { get; set; }
        /// <summary>
        /// 页面Url
        /// </summary>
        public string PageUrl { get; set; }

        /// <summary>
        /// 页面标题
        /// </summary>
        public string PageTitle { get; set; }

        /// <summary>
        /// 父级菜单的PageId，注意：该属性标注只针对主菜单而不是功能
        /// </summary>
        public int ParentMenuPageId { get; set; }


        /// <summary>
        /// 菜单排序的序号
        /// </summary>
        public int MenuSortNum { get; set; }
        

        /// <summary>
        /// 当前页面是否是功能页面，即由某个按钮或链接打开的页面
        /// </summary>
        public int IsFunPage { get; set; }
        /// <summary>
        /// 当前页面是否是功能页面，即由某个按钮或链接打开的页面
        /// </summary>
        public bool IsFunPageStatus => IsFunPage > 0;

        /// <summary>
        /// 当前页面中所有的功能
        /// </summary>
        public IList<Sys_PageFunEntity> PageFuns { get; set; }


    }


    
}
