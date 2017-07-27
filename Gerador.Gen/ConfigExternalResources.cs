using Common.Gen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Gen
{
    public class ConfigExternalResources
    {

        private ExternalResource ConfigExternarResourcesTemplatesFrontBs4Angular20(bool replaceLocalFilesApplication)
        {

            return new ExternalResource
            {
                ReplaceLocalFilesApplication = replaceLocalFilesApplication,
                ResouceRepositoryName = "template-gerador-front-bs4-angular2.0",
                ResourceUrlRepository = "https://github.com/wilsonsantosnet/template-gerador-front-bs4-angular2.0.git",
                ResourceLocalPathFolderExecuteCloning = @"C:\Projetos\Outros\Repositorios",
                ResourceLocalPathDestinationFolrderApplication = @"C:\Projetos\seed-core-ddd-project-with-gerador-empty\Gerador.Gen\Templates\Front",
            };

        }

        private ExternalResource ConfigExternarResourcesTemplatesBackDDD(bool replaceLocalFilesApplication)
        {

            return new ExternalResource
            {
                ReplaceLocalFilesApplication = true,
                ResouceRepositoryName = "template-gerador-back-DDD",
                ResourceUrlRepository = "https://github.com/wilsonsantosnet/template-gerador-back-DDD.git",
                ResourceLocalPathFolderExecuteCloning = @"C:\Projetos\Outros\Repositorios",
                ResourceLocalPathDestinationFolrderApplication = @"C:\Projetos\seed-core-ddd-project-with-gerador-empty\Gerador.Gen\Templates\Back"
            };

        }

        private ExternalResource ConfigExternarResourcesFrameworkAngula20Crud(bool replaceLocalFilesApplication)
        {

            return new ExternalResource
            {
                ReplaceLocalFilesApplication = true,
                ResouceRepositoryName = "framework-angular2.0-CRUD",
                ResourceUrlRepository = "https://github.com/wilsonsantosnet/framework-angular2.0-CRUD.git",
                ResourceLocalPathFolderExecuteCloning = @"C:\Projetos\Outros\Repositorios",
                ResourceLocalPathDestinationFolrderApplication = @"C:\Projetos\seed-core-ddd-project-with-gerador-empty\Target.seed-core-ddd-project-with-gerador-emptys.Spa.Ui.V4\src\app\common"
            };

        }

        private ExternalResource ConfigExternarResourcesFrameworkCommon(bool replaceLocalFilesApplication)
        {

            return new ExternalResource
            {
                ReplaceLocalFilesApplication = true,
                OnlyFoldersContainsThisName = "Common",
                ResouceRepositoryName = "framework-core-common",
                ResourceUrlRepository = "https://github.com/wilsonsantosnet/framework-core-common.git",
                ResourceLocalPathFolderExecuteCloning = @"C:\Projetos\Outros\Repositorios",
                ResourceLocalPathDestinationFolrderApplication = @"C:\Projetos\seed-core-ddd-project-with-gerador-empty"
            };

        }

        private ExternalResource ConfigExternarResourcesSeedLayoutBs4Angular20(bool replaceLocalFilesApplication)
        {

            return new ExternalResource
            {
                ReplaceLocalFilesApplication = true,
                DownloadOneTime = true,
                ResouceRepositoryName = "Seed-layout-front-bs4-angular2.0",
                ResourceUrlRepository = "https://github.com/wilsonsantosnet/Seed-layout-front-bs4-angular2.0.git",
                ResourceLocalPathFolderExecuteCloning = @"C:\Projetos\Outros\Repositorios",
                ResourceLocalPathDestinationFolrderApplication = @"C:\Projetos\seed-core-ddd-project-with-gerador-empty\Seed.Spa.Ui"
			};

        }



        public IEnumerable<ExternalResource> GetConfigExternarReources()
        {
            var replaceLocalFilesApplication = true;

            return new List<ExternalResource>
            {

               ConfigExternarResourcesTemplatesBackDDD(replaceLocalFilesApplication),
               ConfigExternarResourcesFrameworkCommon(replaceLocalFilesApplication),
               ConfigExternarResourcesTemplatesFrontBs4Angular20(replaceLocalFilesApplication),
               ConfigExternarResourcesFrameworkAngula20Crud(replaceLocalFilesApplication),
               ConfigExternarResourcesSeedLayoutBs4Angular20(replaceLocalFilesApplication),

            };

        }


    }
}
