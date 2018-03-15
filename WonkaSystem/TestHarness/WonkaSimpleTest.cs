using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WonkaBre;
using WonkaPrd;
using WonkaRef;

namespace WonkaSystem.TestHarness
{
    public class WonkaSimpleTest
    {
        private const string CONST_SIMPLE_RULES_FILEPATH =
            @"/Users/JohnnySpiffeknutz/SimpleAccountCheck.xml";

        private IMetadataRetrievable moMetadataSource = null;

        public WonkaSimpleTest()
        {
            moMetadataSource = new WonkaMetadataTestSource();
        }

		public void Execute()
        {
            WonkaRefEnvironment RefEnv =
                WonkaRefEnvironment.CreateInstance(false, moMetadataSource);

			WonkaRefAttr AccountStsAttr = RefEnv.GetAttributeByAttrName("AccountStatus");

            WonkaProduct NewProduct = GetNewProduct();            
            
            string sStatusValueBefore = GetAttributeValue(NewProduct, AccountStsAttr);
            
            /* 
             * NOT YET READY
             *
			// Cue the rules engine
			WonkaBreRulesEngine RulesEngine =
                new WonkaBreRulesEngine(CONST_SIMPLE_RULES_FILEPATH, moMetadataSource);

            RulesEngine.GetCurrentProductDelegate = GetOldProduct;

            WonkaBre.Reporting.WonkaBreRuleTreeReport Report = RulesEngine.Validate(NewProduct);

			string sStatusValueAfter = GetAttributeValue(NewProduct, AccountStsAttr);

			if (Report.GetRuleSetFailureCount() > 0)
            {
                throw new Exception("Oh heavens to Betsy! Something bad happened!"); 
            }
            */
        }

        public WonkaProduct GetOldProduct(Dictionary<string,string> poProductKeys)
        {
            WonkaRefEnvironment PmdRefEnv           = WonkaRefEnvironment.GetInstance();
            WonkaRefAttr        AccountIDAttr       = PmdRefEnv.GetAttributeByAttrName("BankAccountID");
            WonkaRefAttr        AccountNameAttr     = PmdRefEnv.GetAttributeByAttrName("BankAccoutName");
            WonkaRefAttr        AccountStsAttr      = PmdRefEnv.GetAttributeByAttrName("AccountStatus");
            WonkaRefAttr        AccountCurrValAttr  = PmdRefEnv.GetAttributeByAttrName("AccountCurrValue");
            WonkaRefAttr        AccountTypeAttr     = PmdRefEnv.GetAttributeByAttrName("AccountType");
            WonkaRefAttr        AccountCurrencyAttr = PmdRefEnv.GetAttributeByAttrName("AccountCurrency");

            WonkaProduct OldProduct = new WonkaProduct();

            SetAttribute(OldProduct, AccountIDAttr,       "1234567890");
            SetAttribute(OldProduct, AccountNameAttr,     "JohnSmithFirstCheckingAccount");
            // SetAttribute(OldProduct, AccountStsAttr,      "ACT");
            SetAttribute(OldProduct, AccountStsAttr,      "OOS");
            SetAttribute(OldProduct, AccountCurrValAttr,  "100.00");
            SetAttribute(OldProduct, AccountCurrencyAttr, "USD");
            SetAttribute(OldProduct, AccountTypeAttr,     "Checking");

            return OldProduct;            
        }

        public WonkaProduct GetNewProduct()
        {
            WonkaRefEnvironment PmdRefEnv           = WonkaRefEnvironment.GetInstance();
            WonkaRefAttr        AccountIDAttr       = PmdRefEnv.GetAttributeByAttrName("BankAccountID");
			WonkaRefAttr        AccountNameAttr     = PmdRefEnv.GetAttributeByAttrName("BankAccoutName");
			WonkaRefAttr        AccountStsAttr      = PmdRefEnv.GetAttributeByAttrName("AccountStatus");
            WonkaRefAttr        AccountCurrValAttr  = PmdRefEnv.GetAttributeByAttrName("AccountCurrValue");
			WonkaRefAttr        AccountTypeAttr     = PmdRefEnv.GetAttributeByAttrName("AccountType");
            WonkaRefAttr        AccountCurrencyAttr = PmdRefEnv.GetAttributeByAttrName("AccountCurrency");

            WonkaProduct NewProduct = new WonkaProduct();

            SetAttribute(NewProduct, AccountIDAttr,       "1234567890");
            SetAttribute(NewProduct, AccountNameAttr,     "JohnSmithFirstCheckingAccount");
            SetAttribute(NewProduct, AccountStsAttr,      "ACT");
            SetAttribute(NewProduct, AccountCurrValAttr,  "100.00");
            SetAttribute(NewProduct, AccountCurrencyAttr, "USD");
			// SetAttribute(NewProduct, AccountTypeAttr,     "Checking");
            SetAttribute(NewProduct, AccountTypeAttr,     "CompletelyBogusTypeThatWillCauseAnError");

            return NewProduct;
		}

		public string GetAttributeValue(WonkaProduct poTargetProduct, WonkaRefAttr poTargetAttr)
		{
			if (poTargetProduct.GetProductGroup(poTargetAttr.GroupId).GetRowCount() <= 0)
				throw new Exception("ERROR!  Provided incoming product has empty group.");

			string sAttrValue = poTargetProduct.GetProductGroup(poTargetAttr.GroupId)[0][poTargetAttr.AttrId];

			if (String.IsNullOrEmpty(sAttrValue))
				throw new Exception("ERROR!  Provided incoming product has no value for needed key(" + poTargetAttr.AttrName + ").");

            return sAttrValue;
		}

		public void SetAttribute(WonkaProduct poTargetProduct, WonkaRefAttr poTargetAttr, string psTargetValue)
        {
            if (poTargetProduct.GetProductGroup(poTargetAttr.GroupId).GetRowCount() <= 0)
                poTargetProduct.GetProductGroup(poTargetAttr.GroupId).AppendRow();

            poTargetProduct.GetProductGroup(poTargetAttr.GroupId)[0][poTargetAttr.AttrId] = psTargetValue;
		}
    }
}
