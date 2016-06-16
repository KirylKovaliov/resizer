﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer.Plugins.Basic
{
    public class WebConfigLicenseReader: ILicenseProvider, IPlugin
    {
        public ICollection<string> GetLicenses()
        {
            return licenses;
        }

        private IList<string> licenses = new List<string>();
        public IPlugin Install(Configuration.Config c)
        {   
            var node = c.getNode("licenses");
            if (node != null)
            {
                foreach (var child in node.childrenByName("license"))
                {
                    if (child.TextContents != null)
                    {
                        licenses.Add(child.TextContents.Trim().Replace(" ", "").Replace("\t", "").Replace("\n", "").Replace("\r", ""));
                    }
                }
            }
            c.Plugins.add_plugin(this);
            return this;
        }

        public bool Uninstall(Configuration.Config c)
        {
            c.Plugins.remove_plugin(this);
            return true;
        }
    }
}
