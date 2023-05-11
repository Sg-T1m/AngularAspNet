using AngularAspNet.Model;
using Microsoft.EntityFrameworkCore;

namespace AngularAspNet.Repository
{
    public class RepositoryData
    {
        CUsersPerevSourceReposAngularaspnetAngularaspnetAppdataDataaccessoriesMdfContext db = new CUsersPerevSourceReposAngularaspnetAngularaspnetAppdataDataaccessoriesMdfContext();
        public List<Component> GetAllComponets()
        {
           
            List<Component> Components = db.Components.Include(c=> c.ComponentsType).Include(c => c.Manufacturers).ToList();
            return Components;
        }

        public List<Component> GetTypeData(int id)
        {

   
           var DataType = db.Components.Where(p => p.ComponentsType.Id == id).ToList();
            return DataType;
        }

        public List<Compatibility> GetCompatibiltesa(int id)
        {

            var DataType = db.Compatibilities.Where(p => p.ComponentId1 == id).Include(p => p.ComponentId2Navigation).ToList();
            //.Components.Where(p => p.Compatibilities.ComponentId1).ToList();

            return DataType;
        }





    }
}
