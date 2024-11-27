using Locate_Assets_Package;
using Locate_Assets_Package.APIClients;
using Locate_Assets_Package.Model;
using System.Text.Json;
using System.Text.Json.Nodes;

var locateAssetsPackageClient = new LocateAssetsPackageClient("You_client_id", "You_client_secret", EnvironmentType.Sandbox);
JsonObject report, archiveReport;

Console.WriteLine("Test GetReport:");

var PropertySearchRequestModel = JsonSerializer.Serialize<PropertySearchRequestModel>(new PropertySearchRequestModel()
{
     OwnerInfo = new OwnerInfo() {
        PersonName = new PersonName() {
            FirstName = "LORENZO A",
            LastName = "FOSTER"
        }
    },
      PropertyAddress = new PostAddr() {
        Addr1 = "530 EAKER WAY",
        City = "ANTIOCH",
        StateProv = "CA",
        PostalCode = "94509"
      }
});

report = locateAssetsPackageClient.PropertySearchClient.GetReport(PropertySearchRequestModel);
Console.WriteLine("GetReport = {0}", report.ToString());
Console.WriteLine("Test GetArchiveReport:");
archiveReport = locateAssetsPackageClient.PropertySearchClient.GetArchiveReport("{0B75ABF4-0360-48BC-816D-6687FB7089F0}");
Console.WriteLine("GetArchiveReport = {0}", archiveReport.ToString());
Console.ReadKey();
