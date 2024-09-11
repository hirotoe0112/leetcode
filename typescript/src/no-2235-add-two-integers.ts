function sum(num1: number, num2: number): number {
  return num1 + num2;
};

// Parse the command line arguments
// NOTE: In JavaScript, the first two arguments are always the path to Node.js and the path to the script being run
const num1 = parseInt(process.argv[2])
const num2 = parseInt(process.argv[3])
console.log(sum(num1, num2));