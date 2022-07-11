using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaBolsoReader
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AcceptedContracts
    {
        [JsonProperty("automatic")]
        public bool Automatic { get; set; }

        [JsonProperty("privacy")]
        public bool Privacy { get; set; }

        [JsonProperty("terms")]
        public bool Terms { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }
    }

    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created")]
        public object Created { get; set; }

        [JsonProperty("modified")]
        public object Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("account")]
        public string AccountValue { get; set; }

        [JsonProperty("accountDigit")]
        public string AccountDigit { get; set; }

        [JsonProperty("accountStatus")]
        public int AccountStatus { get; set; }

        [JsonProperty("accountType")]
        public int AccountType { get; set; }

        [JsonProperty("accountConnectionType")]
        public int AccountConnectionType { get; set; }

        [JsonProperty("accountConnectionTypeName")]
        public string AccountConnectionTypeName { get; set; }

        [JsonProperty("bank")]
        public Bank Bank { get; set; }

        [JsonProperty("update")]
        public Update Update { get; set; }

        [JsonProperty("statements")]
        public List<Statement> Statements { get; set; }
    }

    public class Actual
    {
        [JsonProperty("income")]
        public double Income { get; set; }

        [JsonProperty("outcome")]
        public double Outcome { get; set; }

        [JsonProperty("saved")]
        public double Saved { get; set; }
    }

    public class Auth
    {
    }

    public class BalanceInfo
    {
        [JsonProperty("accounts")]
        public double Accounts { get; set; }

        [JsonProperty("cards")]
        public double Cards { get; set; }

        [JsonProperty("investments")]
        public double Investments { get; set; }

        [JsonProperty("money")]
        public object Money { get; set; }

        [JsonProperty("loans")]
        public object Loans { get; set; }

        [JsonProperty("wallet")]
        public object Wallet { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class Bank
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("identifier")]
        public object Identifier { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userCategory")]
        public bool UserCategory { get; set; }
    }

    public class Category2
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("categoryType")]
        public string CategoryType { get; set; }
    }

    public class CategoryType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
    }

    public class Delta
    {
        [JsonProperty("income")]
        public double Income { get; set; }

        [JsonProperty("outcome")]
        public double Outcome { get; set; }
    }

    public class Estimated
    {
        [JsonProperty("income")]
        public object Income { get; set; }

        [JsonProperty("outcome")]
        public object Outcome { get; set; }

        [JsonProperty("saved")]
        public object Saved { get; set; }
    }

    public class EstimatedEconomy
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }
    }

    public class FinanceSummary
    {
        [JsonProperty("actual")]
        public Actual Actual { get; set; }

        [JsonProperty("estimated")]
        public Estimated Estimated { get; set; }

        [JsonProperty("delta")]
        public Delta Delta { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("estimatedEconomy")]
        public EstimatedEconomy EstimatedEconomy { get; set; }

        [JsonProperty("balanceInfo")]
        public BalanceInfo BalanceInfo { get; set; }

        [JsonProperty("recentTransactions")]
        public List<RecentTransaction> RecentTransactions { get; set; }

        [JsonProperty("lastUpdateDate")]
        public object LastUpdateDate { get; set; }
    }

    public class Identity
    {
    }

    public class Metadata
    {
    }

    public class Parameters
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Payload
    {
        [JsonProperty("rawData")]
        public RawData RawData { get; set; }

        [JsonProperty("financeSummary")]
        public FinanceSummary FinanceSummary { get; set; }

        [JsonProperty("userMonthHistory")]
        public UserMonthHistory UserMonthHistory { get; set; }
    }

    public class RadarCPF
    {
        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("hasChanges")]
        public bool HasChanges { get; set; }
    }

    public class RawData
    {
        [JsonProperty("firstTransaction")]
        public string FirstTransaction { get; set; }

        [JsonProperty("categoryTypes")]
        public List<CategoryType> CategoryTypes { get; set; }

        [JsonProperty("statementTypeGroups")]
        public List<StatementTypeGroup> StatementTypeGroups { get; set; }

        [JsonProperty("accounts")]
        public List<Account> Accounts { get; set; }

        [JsonProperty("radarCPF")]
        public RadarCPF RadarCPF { get; set; }

        [JsonProperty("acceptedContracts")]
        public AcceptedContracts AcceptedContracts { get; set; }

        [JsonProperty("lending")]
        public object Lending { get; set; }

        [JsonProperty("wellnessScore")]
        public object WellnessScore { get; set; }
    }

    public class RecentTransaction
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("date")]
        public object Date { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("serieId")]
        public object SerieId { get; set; }
    }

    public class Root
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("flowId")]
        public string FlowId { get; set; }

        [JsonProperty("auth")]
        public Auth Auth { get; set; }

        [JsonProperty("identity")]
        public Identity Identity { get; set; }

        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class Statement
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created")]
        public object Created { get; set; }

        [JsonProperty("modified")]
        public object Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statementType")]
        public string StatementType { get; set; }

        [JsonProperty("statementStatus")]
        public string StatementStatus { get; set; }

        [JsonProperty("creditCardFinalNumbers")]
        public string CreditCardFinalNumbers { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        [JsonProperty("series")]
        public List<object> Series { get; set; }

        [JsonProperty("statementTypeId")]
        public int StatementTypeId { get; set; }
    }

    public class StatementType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class StatementTypeGroup
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statementTypes")]
        public List<StatementType> StatementTypes { get; set; }
    }

    public class Status
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Transaction
    {
        [JsonProperty("statementId")]
        public int StatementId { get; set; }

        [JsonProperty("serieId")]
        public object SerieId { get; set; }

        [JsonProperty("isVisualized")]
        public bool IsVisualized { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("originalValue")]
        public double OriginalValue { get; set; }

        [JsonProperty("date")]
        public double Date { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("monthCode")]
        public int MonthCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("modified")]
        public object Modified { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("exchangeValue")]
        public double ExchangeValue { get; set; }

        [JsonProperty("duplicated")]
        public bool Duplicated { get; set; }

        [JsonProperty("created")]
        public object Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Update
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("last")]
        public object Last { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UserBudget
    {
        [JsonProperty("spent")]
        public double Spent { get; set; }

        [JsonProperty("delta")]
        public double Delta { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }

    public class UserMonthHistory
    {
        [JsonProperty("statements")]
        public List<Statement> Statements { get; set; }

        [JsonProperty("userBudgets")]
        public List<UserBudget> UserBudgets { get; set; }
    }



}
