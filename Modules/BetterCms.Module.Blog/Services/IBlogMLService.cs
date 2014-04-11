﻿using System.Collections.Generic;
using System.IO;
using System.Security.Principal;

using BetterCms.Module.Blog.Models;

using BlogML.Xml;

namespace BetterCms.Module.Blog.Services
{
    public interface IBlogMLService
    {
        BlogMLBlog DeserializeXMLFile(string filePath);
        
        BlogMLBlog DeserializeXMLStream(Stream fileStream);

        List<BlogPost> ImportBlogs(BlogMLBlog blogPosts, IPrincipal principal, bool useOriginalUrls = false, bool createRedirects = false);
    }
}