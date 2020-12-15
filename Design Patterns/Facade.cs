using System;

namespace DesignPatterns {

    class Program {
        AccountInformation acctInfo = new AccountInformation();
        CreditCardInformation ccInfo = new CreditCardInformation();
        BankFacade facade = new BankFacade(acctInfo, ccInfo);
        MobileClient.Execute(facade);
    }

    class MobileClient {
        public static Execute(BankFacade facade) {
            facade.AllOperation();
        }
    }

    class BankFacade {
        private AccountInformation _accInfo;
        private CreditCardInformation _ccInfo;

        public BankFacade(AccountInformation accInfo, CreditCardInformation ccInfo) {
            this._accInfo = accInfo;
            this._ccInfo = ccInfo;
        }

        public String AllOperation() {
            this.Operation();
            //this.Operation1();
            //this.OperationN();
        }

        public String Operation() {
            Console.WriteLine('Startin the banking facade');
            string result = "Call log \n";
            result += this._accInfo.getAccountDetails();
            result += this._ccInfo.getCreditCardDetails();
            result += this._accInfo.showLastFiveTransactions();
            result += this._ccInfo.showAvailableLimit();

            return result;
        }
    }

    class AccountInformation {
        public String getAccountDetails () {
            return "this is bank account info";
        }

        public string showLastFiveTransactions() {
            return "last 5 transactions";
        }
    }

    class CreditCardInformation {
        public string getCreditCardDetails() {
            return "welcome to abc bank credit card";
        }

        public string showAvailableLimit () {
            return "your limit is $10000";
        }
    }

}