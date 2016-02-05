using Orchard.UI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.AngularJs
{
    public class ResourceManifest : IResourceManifestProvider
    {
        private const string Version = "1.4.9";

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            addVersion(Version, manifest);
        }

        private void addVersion(string version, UI.Resources.ResourceManifest manifest)
        {
            var baseDir = string.Format("angular-{0}/", version);

            manifest.DefineScript("AngularJs")
                .SetUrl(baseDir + "angular.min.js", baseDir + "angular.js")
                .SetVersion(version)
                .SetCdn(string.Format("//ajax.googleapis.com/ajax/libs/angularjs/{0}/angular.min.js", version),
                        string.Format("//ajax.googleapis.com/ajax/libs/angularjs/{0}/angular.js", version),
                        true);

            manifest.DefineStyle("Angular.Csp")
                .SetUrl(baseDir + "angular.csp.css")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Aria")
                .SetUrl(baseDir + "angular-aria.min.js", baseDir + "angular-aria.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Animate")
                .SetUrl(baseDir + "angular-animate.min.js", baseDir + "angular-animate.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Cookies")
                .SetUrl(baseDir + "angular-cookies.min.js", baseDir + "angular-cookies.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Loader")
                .SetUrl(baseDir + "angular-loader.min.js", baseDir + "angular-loader.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Message.Format")
                .SetUrl(baseDir + "angular-message-format.min.js", baseDir + "angular-message-format.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);
            
            manifest.DefineScript("AngularJs.Messages")
                .SetUrl(baseDir + "angular-messages.min.js", baseDir + "angular-messages.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Mocks")
                .SetUrl(baseDir + "angular-mocks.min.js", baseDir + "angular-mocks.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Resource")
                .SetUrl(baseDir + "angular-resource.min.js", baseDir + "angular-resource.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Route")
                .SetUrl(baseDir + "angular-route.min.js", baseDir + "angular-route.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Sanitize")
                .SetUrl(baseDir + "angular-sanitize.min.js", baseDir + "angular-sanitize.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Scenario")
                .SetUrl(baseDir + "angular-scenario.min.js", baseDir + "angular-scenario.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            manifest.DefineScript("AngularJs.Touch")
                .SetUrl(baseDir + "angular-touch.min.js", baseDir + "angular-touch.js")
                .SetDependencies("AngularJs")
                .SetVersion(version);

            //    manifest.DefineScript("AngularJs.holder")
            //        .SetUrl(baseDir + "angular-holder.min.js", baseDir + "angular-holder.js")
            //        .SetDependencies("AngularJs")
            //        .SetVersion(version);
        }
    }
}