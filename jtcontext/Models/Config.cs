using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTracker.jtcontext.Models
{
    [Table("Config")]
    public class Config
    {
        public long ConfigId { get; set; }

        [Column(TypeName = "text")]
        public string KeyName { get; set; }

        [Column(TypeName = "text")]
        public string KeyValue { get; set; }

        [Column(TypeName = "text")]
        public string DataType { get; set; }

        public byte Active { get; set; }
    }
}