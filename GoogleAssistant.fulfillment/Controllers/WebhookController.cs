using Google.Apis.Dialogflow.v2.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoogleAssistant.fulfillment.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class WebhookController : ControllerBase {

    [HttpGet]
    public ActionResult<string> Get() {
      return "v0.0.0.1";
    }

    // POST api/webhook
    [HttpPost]
    public ActionResult<GoogleCloudDialogflowV2WebhookResponse> Post([FromBody] GoogleCloudDialogflowV2WebhookRequest request) {
      
      //request.QueryResult.Parameters      
      //DialogflowBaseServiceRequest req = new 

      var response = new GoogleCloudDialogflowV2WebhookResponse() {
        FulfillmentText = "Hello from " + request.QueryResult.Intent.DisplayName
      };

      return response;
    }
  }
}
