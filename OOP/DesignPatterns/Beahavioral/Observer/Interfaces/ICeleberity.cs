using System.Text;

namespace OOP.DesignPatterns.Beahavioral
{
    public interface ICeleberity
    {
        string FullName { get; }
        string Tweet { get; set; }
        void Nodify(string tweet);
        void AddFollower(IFan fan);
        void RemoveFollower(IFan fan);
    }
}
