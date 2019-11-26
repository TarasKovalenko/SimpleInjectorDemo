using System;

namespace SimpleInjectorDemo.Models
{
    public class SqlQueryModel
    {
        private string _repo;
        private int _id;

        public string Repo
        {
            get => _repo;
            set => _repo = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Id
        {
            get => _id;
            set => _id = value < 1001 ? throw new ArgumentOutOfRangeException(nameof(value), "Invalid Id") : value;
        }

        public DlpQuery DlpQuery { get; set; }
        public WorkspaceQuery WorkspaceQuery { get; set; }
    }

    public class DlpQuery
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
    }

    public class WorkspaceQuery
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
    }
}
