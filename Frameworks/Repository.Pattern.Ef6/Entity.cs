using System.ComponentModel.DataAnnotations.Schema;
using Repository.Pattern.Infrastructure;
using System;

namespace Repository.Pattern.Ef6
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> InActivatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> UpdatedDate { get; set; }
        public Nullable<DateTime> InActivatedDate { get; set; }
        public Nullable<bool> IsInActive { get; set; }

    }
}