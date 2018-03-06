using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WonkaRef;

namespace WonkaSystem.TestHarness
{
    public class WonkaMetadataTestSource : IMetadataRetrievable
    {
        public WonkaMetadataTestSource()
        { }

        #region Standard Metadata Cache (Minimum Set)

        public List<WonkaRefAttr> GetAttrCache()
        {
            List<WonkaRefAttr> AttrCache = new List<WonkaRefAttr>();

            AttrCache.Add(new WonkaRefAttr() { AttrId = 1, AttrName = "BankAccountID",   FieldId = 101, GroupId = 1, IsAudited = false, IsNumeric = true });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 2, AttrName = "BankAccoutName",  FieldId = 102, GroupId = 1, IsAudited = true,  MaxLength = 1024 });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 3, AttrName = "AccountType",     FieldId = 2,   GroupId = 2, IsAudited = false, MaxLength = 1024 });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 4, AttrName = "AccountTypeRank", FieldId = 2,   GroupId = 2, IsAudited = true,  MaxLength = 1024 });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 5, AttrName = "BankAccoutName",  FieldId = 2,   GroupId = 2, IsAudited = true,  MaxLength = 1024 });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 6, AttrName = "BankAccoutName",  FieldId = 2,   GroupId = 2, IsAudited = true,  MaxLength = 1024 });

            return AttrCache;
        }

        public List<WonkaRefCurrency> GetCurrencyCache()
        {
            List<WonkaRefCurrency> CurrencyCache = new List<WonkaRefCurrency>();

            return CurrencyCache;
        }

        public List<WonkaRefField> GetFieldCache()
        {
            List<WonkaRefField> FieldCache = new List<WonkaRefField>();

            return FieldCache;
        }

        public List<WonkaRefGroup> GetGroupCache()
        {
            List<WonkaRefGroup> GroupCache = new List<WonkaRefGroup>();

            return GroupCache;
        }

        public List<WonkaRefSource> GetSourceCache()
        {
            List<WonkaRefSource> SourceCache = new List<WonkaRefSource>();

            return SourceCache;
        }

        public List<WonkaRefSourceField> GetSourceFieldCache()
        {
            List<WonkaRefSourceField> SourceFieldCache = new List<WonkaRefSourceField>();

            return SourceFieldCache;
        }

        public List<WonkaRefStandard> GetStandardCache()
        {
            List<WonkaRefStandard> StandardCache = new List<WonkaRefStandard>();

            return StandardCache;
        }

        #endregion

        #region Extended Metadata Cache

        public List<WonkaRefAttrCollection> GetAttrCollectionCache()
        {
            List<WonkaRefAttrCollection> AttrCollCache = new List<WonkaRefAttrCollection>();

            return AttrCollCache;
        }

        #endregion
    }
}
