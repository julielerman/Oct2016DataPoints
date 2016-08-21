
using System.Linq;
using EFCoreCoreCLR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Tests
{
   
    public class TestEFCoreFullNet
  {
    private DbContextOptions<SamuraiContext> _options;

    public TestEFCoreFullNet() {
      var optionsBuilder = new DbContextOptionsBuilder<SamuraiContext>();
      optionsBuilder.UseInMemoryDatabase();
      _options = optionsBuilder.Options;
    }

    [Fact]
    public void CanAddAndUpdateSomeData() {
      var samurai = new Samurai { Name = "Julie" };
      using (var context = new SamuraiContext(_options)) {
        context.Add(samurai);
        context.SaveChanges();
      }
      samurai.Name += "San";
      using (var context = new SamuraiContext(_options)) {
        context.Samurais.Update(samurai);
        context.SaveChanges();
      }
      using (var context = new SamuraiContext(_options)) {
        Assert.Equal("JulieSan", context.Samurais.FirstOrDefault().Name);
      }
    }
  }
}