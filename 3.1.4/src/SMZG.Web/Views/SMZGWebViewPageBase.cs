using Abp.Web.Mvc.Views;

namespace SMZG.Web.Views
{
    public abstract class SMZGWebViewPageBase : SMZGWebViewPageBase<dynamic>
    {

    }

    public abstract class SMZGWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SMZGWebViewPageBase()
        {
            LocalizationSourceName = SMZGConsts.LocalizationSourceName;
        }
    }
}