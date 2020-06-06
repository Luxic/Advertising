using Advertising.ViewModels;
using System.Threading.Tasks;

namespace Advertising.Interfaces
{
	public interface IApplicationService
	{
		Task<MenuFormIndexViewModel> GetMenus(int userId);
	}
}
