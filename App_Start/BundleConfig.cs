using System.Web;
using System.Web.Optimization;
using System.Web.Mvc;

namespace ERPIOT_1._1
{
    public class BundleConfig
    {

        //..Humotronix Software Pvt.Ltd All ERPIOT Copy Right 2015
       
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Script Bundling
            //<!-- start: MAIN JAVASCRIPTS -->
           

           
            //<!-- end: MAIN JAVASCRIPTS -->

            //<!-- start: JAVASCRIPTS REQUIRED FOR THIS PAGE ONLY -->
           
            //<!-- end: JAVASCRIPTS REQUIRED FOR THIS PAGE ONLY -->
            
            #endregion
           

            #region Style Bundling
          
            bundles.Add(new ScriptBundle("~/plugins/bootstrap/css").Include("~/plugins/bootstrap/css/bootstrap.min.css"));
            bundles.Add(new ScriptBundle("~/plugins/font-awesome/css").Include("~/plugins/font-awesome/css/font-awesome.min.css"));
            bundles.Add(new ScriptBundle("~/plugins/animate.css").Include("~/plugins/animate.css/animate.min.css"));
            bundles.Add(new ScriptBundle("~/plugins/iCheck/skins").Include("~/plugins/iCheck/skins/all.css"));
            bundles.Add(new ScriptBundle("~/Content/css").Include("~/Content/css/styles.css",
                                                                "~/Content/css/styles-responsive.css"));
            bundles.Add(new ScriptBundle("~/plugins/iCheck").Include("~/plugins/iCheck/skins/all.css"));
            
            #endregion

            
        }
      
       
    }
}