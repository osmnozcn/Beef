/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Entities
{
    /// <summary>
    /// Represents the Transaction Type entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TransactionType : ReferenceDataBaseGuid
    {
        #region Operator

        /// <summary>
        /// An implicit cast from an <b>Id</b> to a <see cref="TransactionType"/>.
        /// </summary>
        /// <param name="id">The <b>Id</b>.</param>
        /// <returns>The corresponding <see cref="TransactionType"/>.</returns>
        public static implicit operator TransactionType(Guid id)
        {
            return ConvertFromId<TransactionType>(id);
        }

        /// <summary>
        /// An implicit cast from a <b>Code</b> to a <see cref="TransactionType"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="TransactionType"/>.</returns>
        public static implicit operator TransactionType(string? code)
        {
            return ConvertFromCode<TransactionType>(code);
        }
        
        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="TransactionType"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="TransactionType"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<TransactionType>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="TransactionType"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="TransactionType"/> to copy from.</param>
        public void CopyFrom(TransactionType from)
        {
            CopyFrom((ReferenceDataBaseGuid)from);

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="TransactionType"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="TransactionType"/>.</returns>
        public override object Clone()
        {
            var clone = new TransactionType();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="TransactionType"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();

            OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                if (!base.IsInitial)
                    return false;

                return true;
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(TransactionType from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="TransactionType"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class TransactionTypeCollection : ReferenceDataCollectionBase<TransactionType>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypeCollection"/> class.
        /// </summary>
        public TransactionTypeCollection(){ }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypeCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="TransactionType"/> entities.</param>
        public TransactionTypeCollection(IEnumerable<TransactionType> entities) => AddRange(entities);

        #endregion
    }
}

#nullable restore