created docker compose and script for ease of use

download the codes to compare

use extensions to build projects

```
dotnet ef dbcontext scaffold "Data Source=tcp:127.0.0.1,1433;Initial Catalog=Northwind;User Id=sa;Password=s3cret-Ninja;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --namespace Northwind.EntityModels --data-annotations

```


```
The command to perform: dbcontext scaffold
• The connection string: "Data Source=tcp:127.0.0.1,1433;Initial
Catalog=Northwind;User Id=sa;Password= s3cret-Ninja';TrustServerCertific
ate=true;"
• The database provider: Microsoft.EntityFrameworkCore.SqlServer
• The namespace: --namespace Northwind.EntityModels
• To use data annotations as well as the Fluent API: --data-annotations

```
use the above code to generate models for the database

