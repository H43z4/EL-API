using Models.DatabaseModels.PermitIssuance.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels.EPRSDatabaseObjects.Core
{
    public class PersonDocuments:BaseModel
    {
        [Key]
        public long DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentPath { get; set; }
        [ForeignKey("Person")]
        public long? PersonId { get; set; }
        public virtual EPRSPerson Person { get; set; }
        [ForeignKey("Application")]
        public long ApplicationId { get; set; }
        public virtual PermitIssueApplication Application { get; set; }
    }
}
