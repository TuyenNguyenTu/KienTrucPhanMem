using Abp.Web.Mvc.Views;

namespace Project.KienTrucPhanMem.Web.Views
{
    public abstract class KienTrucPhanMemWebViewPageBase : KienTrucPhanMemWebViewPageBase<dynamic>
    {

    }

    public abstract class KienTrucPhanMemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected KienTrucPhanMemWebViewPageBase()
        {
            LocalizationSourceName = KienTrucPhanMemConsts.LocalizationSourceName;
        }
    }
}