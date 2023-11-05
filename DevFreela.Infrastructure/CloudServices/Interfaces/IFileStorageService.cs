// Classe que serve para garantir que diferentes classes ou serviços que precisam lidar com o armazenamento de arquivos sigam
// um conjunto de regras e métodos, tornando o códig mais organizado e flexível.

namespace DevFreela.Infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}
