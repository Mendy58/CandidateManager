using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_5_6_2019.Data
{
    public class CandidateRepository
    {
        private string _connectionstring;

        public CandidateRepository(string _ConnectionString)
        {
            _connectionstring = _ConnectionString;
        }
        public IEnumerable<Candidate> GetPendingCandidates()
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                return CC.Candidates.Where(c => c.Confirmed == null).ToList();
            }
        }
        public IEnumerable<Candidate> GetConfirmedCandidates()
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                return CC.Candidates.Where(c => c.Confirmed == true).ToList();
            }
        }
        public IEnumerable<Candidate> GetDeclinedCandidates()
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                return CC.Candidates.Where(c => c.Confirmed == false).ToList();
            }
        }
        public Candidate GetCandidateByid(int id)
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                return CC.Candidates.FirstOrDefault(c => c.id == id);
            }
        }
        public void ConfirmCandidate(int id)
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                 CC.Candidates.First(c => c.id == id).Confirmed = true;
                CC.SaveChanges();
            }
        }
        public void DeclineCandidate(int id)
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                CC.Candidates.First(c => c.id == id).Confirmed = false;
                CC.SaveChanges();
            }
        }
        public void AddCandidate(Candidate c)
        {
            using (CandidateContext CC = new CandidateContext(_connectionstring))
            {
                CC.Candidates.Add(c);
                CC.SaveChanges();
            }
        }
    }
}
