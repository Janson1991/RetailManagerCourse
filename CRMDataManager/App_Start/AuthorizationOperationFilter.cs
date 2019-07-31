#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CRMDataManager.App_Start
* 类 名 称 ：AuthorizationOperationFilter
* 类 描 述 ：
* 命名空间 ：CRMDataManager.App_Start
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Janson1991@outlook.com
* 创建时间 ：2019-07-31 23:08:48
* 更新时间 ：2019-07-31 23:08:48
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
    public class AuthorizationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "access token",
                required = false,
                type = "string"
            });

        }
    }
}