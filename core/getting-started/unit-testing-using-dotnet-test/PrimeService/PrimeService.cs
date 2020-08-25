using System;

namespace Prime.Services {
    public class PrimeService {
        public bool IsPrime(int candidate) {
            if(candidate < 2) return false;

            for(var divisor = 2; divisor <= candidate; divisor++) {
                if(candidate % divisor == 0) return false;
            }
            
            return true;
        }
    }
}
