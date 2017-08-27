using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Search_Google
{
	[Cmdlet(VerbsCommunications.Send, "https://www.google.com/search?q=")]
    public class GoogleSearchCmdlet : Cmdlet
    {
		[Parameter]
		public string SearchString { get; set; }

		private void search(string url)
	    {

	    }
}
