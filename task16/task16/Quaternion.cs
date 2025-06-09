using System;
using System.Collections.Generic;

namespace task16
{
    public struct Quaternion
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly double _d;

        public double A => _a;
        public double B => _b;
        public double C => _c;
        public double D => _d;

        public double Abs => Math.Sqrt(_a * _a + _b * _b + _c * _c + _d * _d);

        public Quaternion(double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public override string ToString()
        {
            var parts = new List<string>();

            if (_a != 0)
                parts.Add($"{_a}");

            if (_b != 0)
                parts.Add((_b > 0 ? "+" : "") + $"{_b}i");

            if (_c != 0)
                parts.Add((_c > 0 ? "+" : "") + $"{_c}j");

            if (_d != 0)
                parts.Add((_d > 0 ? "+" : "") + $"{_d}k");

            return parts.Count == 0 ? "0" : string.Join("", parts);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Quaternion))
                return false;

            var other = (Quaternion)obj;
            const double epsilon = 1e-13;
            return
                Math.Abs(_a - other._a) < epsilon &&
                Math.Abs(_b - other._b) < epsilon &&
                Math.Abs(_c - other._c) < epsilon &&
                Math.Abs(_d - other._d) < epsilon;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                const int p = 23;
                hash = hash * p + _a.GetHashCode();
                hash = hash * p + _b.GetHashCode();
                hash = hash * p + _c.GetHashCode();
                hash = hash * p + _d.GetHashCode();
                return hash;
            }
        }

        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1.A + q2.A,
                q1.B + q2.B,
                q1.C + q2.C,
                q1.D + q2.D
            );
        }

        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1.A - q2.A,
                q1.B - q2.B,
                q1.C - q2.C,
                q1.D - q2.D
            );
        }

        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1.A * q2.A - q1.B * q2.B - q1.C * q2.C - q1.D * q2.D,
                q1.A * q2.B + q1.B * q2.A + q1.C * q2.D - q1.D * q2.C,
                q1.A * q2.C - q1.B * q2.D + q1.C * q2.A + q1.D * q2.B,
                q1.A * q2.D + q1.B * q2.C - q1.C * q2.B + q1.D * q2.A
            );
        }

        public static bool operator ==(Quaternion q1, Quaternion q2)
        {
            return q1.Equals(q2);
        }

        public static bool operator !=(Quaternion q1, Quaternion q2)
        {
            return !(q1 == q2);
        }
    }
}