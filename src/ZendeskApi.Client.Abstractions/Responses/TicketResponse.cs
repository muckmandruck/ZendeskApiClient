﻿using System.Collections.Generic;
using Newtonsoft.Json;
using ZendeskApi.Client.Models;

namespace ZendeskApi.Client.Responses
{
    public class TicketResponse
    {
        [JsonProperty("ticket")]
        public Ticket Item { get; set; }
    }

    [JsonObject]
    public class TicketsResponse : PaginationResponse<Ticket>
    {
        [JsonProperty("tickets")]
        public override IEnumerable<Ticket> Item { get; set; }
    }
}
