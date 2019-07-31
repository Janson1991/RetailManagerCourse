#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CRMDataManager.App_Start
* 类 名 称 ：AuthTokenOperation
* 类 描 述 ：
* 命名空间 ：CRMDataManager.App_Start
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Janson1991@outlook.com
* 创建时间 ：2019-07-31 23:07:52
* 更新时间 ：2019-07-31 23:07:52
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @coderzi.com 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace CRMDataManager.App_Start
{
    public class AuthTokenOperation : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths.Add("/token", new PathItem
            {
                post = new Operation
                {
                    tags = new List<string> { "Auth" },
                    consumes = new List<string>
                    {
                        "application/x-www-form-urlencoded"
                    },
                    parameters = new List<Parameter>
                    {
                        new Parameter
                        {
                            type = "string",
                            name = "grant_type",
                            required = true,
                            @in = "formData",
                            @default = "password"
                        },
                        new Parameter
                        {
                            type = "string",
                            name = "username",
                            required = false,
                            @in = "formData"
                        },
                        new Parameter
                        {
                            type = "string",
                            name = "password",
                            required = false,
                            @in = "formData"
                        }
                    }
                }
            });
        }
    }
}