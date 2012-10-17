using System;
using System.Collections.Generic;

namespace core.Quotes.Request
{
    public class QuoteRequestBuilder : IBuildAQuoteRequest
    {
        IEnumerable<string> tickers;

        public IBuildAQuoteRequest For(params string[] tickers)
        {
            this.tickers = tickers;
            return this;
        }

        public IContainQuoteRequestData Return(IEnumerable<QuoteReturnParameter> quote_return_parameters)
        {
            return new QuoteRequest(tickers, quote_return_parameters);
        }
    }
}