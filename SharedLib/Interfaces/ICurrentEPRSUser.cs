using Models.ViewModels.Identity;
using Models.ViewModels.PermitIssuance.Setup;

namespace SharedLib.Interfaces
{
    public interface ICurrentEPRSUser
    {
        public VwEPRSUser VwEPRSUser { get; set; }
    }
}
