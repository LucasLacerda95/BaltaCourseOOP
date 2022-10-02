using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base(){
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }//Guid é um identificador global
    }
}