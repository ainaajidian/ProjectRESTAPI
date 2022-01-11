﻿using Microsoft.EntityFrameworkCore;
using ProjectRESTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRESTAPI.Data
{
    public class EnrollmentDAL : IEnrollment
    {
        private ApplicationDbContext _db;
        public EnrollmentDAL(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Delete(string id)
        {
            try
            {
                var result = await GetById(id);
                if (result == null) throw new Exception($"data course {id} tidak ditemukan");
                _db.Enrollments.Remove(result);
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"error: {dbEx.Message}");
            }
        }

        public async Task<IEnumerable<Enrollment>> GetAll()
        {
            var results = await _db.Enrollments.Include(e => e.Student)
                .Include(e => e.Course).AsNoTracking().ToListAsync();


            return results;
        }

        public async Task<Enrollment> GetById(string id)
        {
            var result = await _db.Enrollments
                                .Where(e => e.EnrollmentID == Convert.ToInt32(id)).SingleOrDefaultAsync<Enrollment>();
            if (result != null)
                return result;
            else
                throw new Exception("Data tidak ditemukan !");
        }

        public async Task<Enrollment> Insert(Enrollment obj)
        {
            try
            {
                _db.Enrollments.Add(obj);
                await _db.SaveChangesAsync();
                return obj;
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"Error: {dbEx.Message}");
            }
        }

        public async Task<Enrollment> Update(string id, Enrollment obj)
        {
            try
            {
                var result = await GetById(id);
                result.CourseID = obj.CourseID;
                result.StudentID = obj.StudentID;
                result.Grade = obj.Grade;
                await _db.SaveChangesAsync();
                obj.EnrollmentID = Convert.ToInt32(id);
                return obj;
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"Error: {dbEx.Message}");
            }
        }
    }
}
