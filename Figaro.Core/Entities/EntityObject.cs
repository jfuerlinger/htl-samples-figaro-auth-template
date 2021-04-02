using System.ComponentModel.DataAnnotations;
using Figaro.Core.Contracts;

namespace Figaro.Core.Entities
{

  public class EntityObject : IEntityObject
        {
            #region IEnityObject Members

            [Key]
            public int Id { get; set; }

            [Timestamp]
            public byte[] Timestamp
            {
                get;
                set;
            }

            #endregion
        }
}
