using _0._0.DataTransferLayer.Objets;
using _4._0.RepositoryLayer.Generic;

namespace _4._0.RepositoryLayer.Repository
{
    public interface RepoUser : RepoGeneric<DtoUser>
    {
        public List<DtoUser> getAll();

        public DtoUser getByPk(string pk);
    }
}