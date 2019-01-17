using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    [Table("Log")]
    public class Log
    {
        public long LogId { get; set; }

        public short LogLevel { get; set; }

        [Column(TypeName = "text")]
        public string SourcePage { get; set; }

        [Column(TypeName = "text")]
        public string SQL { get; set; }

        [Column(TypeName = "text")]
        public string Message { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Generated { get; set; }

        public short Dispositioned { get; set; }

        public DateTime? DispositionDate { get; set; }
    }
}