﻿using System.Collections.Generic;
using Newtonsoft.Json;
using ZendeskApi.Client.Models;

namespace ZendeskApi.Client.Responses
{
    public class TicketFieldResponse
    {
        [JsonProperty("ticket_field")]
        public TicketField Item { get; set; }
    }

    [JsonObject]
    public class TicketFieldsResponse : PaginationResponse<TicketField>
    {
        [JsonProperty("ticket_fields")]
        public override IEnumerable<TicketField> Item { get; set; }
    }
}
