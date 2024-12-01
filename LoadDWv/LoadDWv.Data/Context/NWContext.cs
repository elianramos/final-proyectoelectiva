

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LoadDWv.Data.Context
{
    public partial class NWContext : DbContext

    { public NWContext(DbContextOptions<NWContext> options) base(options)
    }
}
