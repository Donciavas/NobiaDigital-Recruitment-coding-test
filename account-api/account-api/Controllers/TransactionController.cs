using MagnetTradeAccountApi.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MagnetTradeAccountApi.Controllers
{
    [Route("transaction")]
    public class TransactionController : Controller
    {
        [HttpGet("summary-fake")]
        public TransactionSummary SummaryFake()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionSummary>("{\"currentMonth\":17321,\"dueTotal\":1000,\"dueDate\":\"March 28\",\"overDueTotal\":-12845.00,\"daysOfOverDue\":20,\"todayBalance\":-12845.00,\"availableCredit\":12155.00,\"lastUpdated\":\"2022-12-12\"}");
        }

        [HttpGet("by-month-fake")]
        public IEnumerable<TransactionMonth> ByMonthFake()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<TransactionMonth>>("[{\"monthName\":\"Jan\",\"year\":\"2022\",\"sum\":\"£53,772.00\",\"transactions\":[{\"date\":\"2022-01-17T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"},{\"date\":\"2022-01-18T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"},{\"date\":\"2022-01-19T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"}]},{\"monthName\":\"Feb\",\"year\":\"2022\",\"sum\":\"£17,924.00\",\"transactions\":[{\"date\":\"2022-02-17T00:00:00Z\",\"amount\":17924.00,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"9200028704\",\"itemType\":\"INV\",\"itemStatus\":\"Invoiced\"}]},{\"monthName\":\"Mar\",\"year\":\"2022\",\"sum\":\"£17,924.00\",\"transactions\":[{\"date\":\"2022-03-17T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"}]},{\"monthName\":\"Jan\",\"year\":\"2021\",\"sum\":\"£17,924.00\",\"transactions\":[{\"date\":\"2022-01-17T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"}]},{\"monthName\":\"Jan\",\"year\":\"2020\",\"sum\":\"£35,848.00\",\"transactions\":[{\"date\":\"2020-01-17T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"},{\"date\":\"2020-01-17T00:00:00Z\",\"amount\":17924,\"formattedAmount\":\"£17,924.00\",\"customerReference\":\"0059171424\",\"documentReference\":\"1402778595\",\"itemType\":\"INV\",\"itemStatus\":\"Not invoiced\"}]}]");
        }
    }
}