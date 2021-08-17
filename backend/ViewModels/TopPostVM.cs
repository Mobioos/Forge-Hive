
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hive.Backend.DataModels;


namespace Hive.Backend.ViewModels
{
	public partial class TopPostVM 
	{
		public TopPostVM() 
		{
        }

        public string Id  { get; set; }
		public string Content  { get; set; }
		public DateTime PublicationDate  { get; set; }
		public DateTime EndDate  { get; set; }
		public string Picture  { get; set; }
		public string Status  { get; set; }
		public string Type  { get; set; }
        public int Views { get; set; }
        public int Answers { get; set; }

		[Timestamp]
		public byte[] RawVersion { get; set; }
    }
}