﻿using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.ViewModel
{
    public class RecoredCheckoutModelView
    {
        public List<string> BookTitles { get; set; }
        public List<int> MemberIDs { get; set; }
    }
}
