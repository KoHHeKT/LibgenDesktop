﻿using LibgenDesktop.Models.Entities;

namespace LibgenDesktop.ViewModels.Library
{
    internal class ScanResultItemViewModel : ViewModel
    {
        public ScanResultItemViewModel(LibgenObjectType libgenObjectType, int libgenObjectId, string fullFilePath, string relativeFilePath, string authors,
            string title, NonFictionBook libgenObject)
        {
            LibgenObjectType = libgenObjectType;
            LibgenObjectId = libgenObjectId;
            FullFilePath = fullFilePath;
            RelativeFilePath = relativeFilePath;
            Authors = authors;
            Title = title;
            LibgenObject = libgenObject;
        }

        public LibgenObjectType LibgenObjectType { get; }
        public int LibgenObjectId { get; }
        public string FullFilePath { get; }
        public string RelativeFilePath { get; }
        public string Authors { get; }
        public string Title { get; }
        public NonFictionBook LibgenObject { get; }
    }
}