﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value = "Data Not Available") : this()
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType position &&
                   Id == position.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}

