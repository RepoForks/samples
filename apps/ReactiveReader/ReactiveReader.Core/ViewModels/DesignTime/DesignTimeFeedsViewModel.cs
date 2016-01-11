﻿using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core.ViewModels.DesignTime
{
    public class DesignTimeFeedsViewModel : IFeedsViewModel
    {
        public DesignTimeFeedsViewModel()
        {
            Blogs = new ReactiveList<BlogViewModel>()
            {
                new BlogViewModel("John's Blog", new Uri("http://example.com/feed.rss")),
                new BlogViewModel("Jill's Blog", new Uri("http://example.com/feed.rss"))
            };
        }

        public ReactiveCommand<Unit> RemoveBlog { get; }
        public ReactiveCommand<Unit> AddBlog { get; }
        public ReactiveCommand<Unit> PersistData { get; }
        public ReactiveList<BlogViewModel> Blogs { get; set; }
        public ReactiveCommand<Unit> RefreshAll { get; }
        public bool IsLoading { get; }
    }
}