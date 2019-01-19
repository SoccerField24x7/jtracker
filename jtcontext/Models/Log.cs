using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTracker.jtcontext.Models
{
    [Table("Log")]
    public class Log
    {
        public long LogId { get; set; }

        public byte LogLevel { get; set; }

        [Column(TypeName = "text")]
        public string SourcePage { get; set; }

        [Column(TypeName = "text")]
        public string SQL { get; set; }

        [Column(TypeName = "text")]
        public string Message { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Generated { get; set; }

        public byte Dispositioned { get; set; }

        public DateTime? DispositionDate { get; set; }
    }
}