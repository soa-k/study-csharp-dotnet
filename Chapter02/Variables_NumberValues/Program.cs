#region 숫자 타입 기본

//unit: whole numbers(양의 정수, 0 = 부호가 없는 정수)

uint naturalNumber = 23;

//int: integers(양의 정수, 음의 정수, 0)
int integerNumber = -23;

//long: long integers(양의 정수, 음의 정수, 0, int보다 더 큰 범위의 정수)
long longintegerNumber = -1234567890123456789L; //뒤에 반드시 L 또는 l을 붙여야 함, 대문자 L 권장 (소문자 l은 숫자 1과 혼동될 수 있음)

//float: single-precision floating-point numbers(실수, 부동 소수점, 소수점 아래 7자리 정도까지 표현), 뒤에 반드시 f 또는 F를 붙여야 함
float realNumber = 2.3f;

//double: double-precision floating-point numbers(실수, 부동 소수점, 소수점 아래 15자리 정도까지 표현), 뒤에 d 또는 D를 붙일 수 있지만 생략 가능
double anotherRealNumber = 2.3;

//decimal: high-precision decimal numbers(실수, 고정 소수점, 금융 계산 등에 사용, 소수점 아래 28-29자리까지 표현), 뒤에 반드시 m 또는 M을 붙여야 함
decimal moneyAmount = 2.3m;

Console.WriteLine($"부호가 없는 정수 whole number은 uint = {naturalNumber}");
Console.WriteLine($"정수 integer number은 int = {integerNumber}");
Console.WriteLine($"정수 long integer number은 long = {longintegerNumber}, 뒤에 반드시 L을 붙여야 함(소문자 지양)");
Console.WriteLine($"실수 real number은 float = {realNumber}, 뒤에 반드시 f를 붙여야 하며 소수점 아래 7자리 정도까지 표현");
Console.WriteLine($"실수 another real number은 double = {anotherRealNumber}, 뒤에 d를 붙일 수 있지만 생략 가능하며 소수점 아래 15자리 정도까지 표현");
Console.WriteLine($"실수 money amount은 decimal = {moneyAmount}, 뒤에 반드시 m을 붙여야 하며 소수점 아래 28-29자리까지 표현, 금융에선 필히 decimal 사용");


Console.WriteLine($"int users {sizeof(int)} bytes and can store numbers the range {int.MinValue:N0} to {int.MaxValue:N0}"); //약 -2.1억에서 2.1억까지 저장 가능
Console.WriteLine($"double users {sizeof(double)} bytes and can store numbers the range {double.MinValue:N0} to {double.MaxValue:N0}"); //double이 decimal보다 더 적은 메모리로 더 넓은 범위의 수를 저장
Console.WriteLine($"decimal users {sizeof(decimal)} bytes and can store numbers the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");


#endregion


#region 정수 심화: int
//10진수: 일반적으로 사용, 2진수: 컴퓨터 내부에서 사용, 16진수: 메모리 주소나 색상 코드 등에 사용
int decimalNotation = 2_000_000; //10진수 리터럴, 언더스코어(_)는 자리 구분을 위해 사용, 컴파일은 해석하지 않음
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; // 2진수 리터럴, 0b 접두사로 시작
int hexNotation = 0x_001E_8480; // 16진수 리터럴, 0x 접두사로 시작

Console.WriteLine($"decimalNotation == binaryNotation: {decimalNotation == binaryNotation}");
Console.WriteLine($"decimalNotation == hexNotation: {decimalNotation == hexNotation}");
Console.WriteLine($"decimalNotation:N0으로 지역변수를 십진법으로 표현: {decimalNotation:N0}");
Console.WriteLine($"binaryNotation:N0으로 지역변수를 십진법으로 표현: {binaryNotation:N0}");
Console.WriteLine($"hexNotation:N0으로 지역변수를 십진법으로 표현: {hexNotation:N0}");
Console.WriteLine($"decimalNotation:X로 지역변수를 16진법으로 표현: {decimalNotation:X}");
Console.WriteLine($"binaryNotation:X로 지역변수를 16진법으로 표현: {binaryNotation:X}");
Console.WriteLine($"hexNotation:X로 지역변수를 16진법으로 표현: {hexNotation:X}");


#endregion


#region 실수 심화: double과 decimal
//부동소수점은 0.1과 같이 정확히 표현할 수 없는 수를 근사값으로 저장하기 때문에, 계산 결과가 예상과 다를 수 있음
//double과 decimal의 정밀도 비교
Console.WriteLine("Using doubles:");
double doubleValue1 = 0.1;
double doubleValue2 = 0.2;

if (doubleValue1 + doubleValue2 == 0.3)
{
    Console.WriteLine($"{doubleValue1} + {doubleValue2} equals {0.3}");
}
else
{
    Console.WriteLine($"{doubleValue1} + {doubleValue2} does NOT equal {0.3}, it equals {doubleValue1 + doubleValue2}");
}//소수는 2진수 변환 시 딱 떨어지지 않아 오차가 발생, 따라서 정확한 계산을 위해선 decimal 사용 권장

Console.WriteLine("Using decimals:");
decimal decimalValue1 = 0.1m;
decimal decimalValue2 = 0.2m;

if (decimalValue1 + decimalValue2 == 0.3m)
{
    Console.WriteLine($"{decimalValue1} + {decimalValue2} equals {0.3m}");
}
else
{
    Console.WriteLine($"{decimalValue1} + {decimalValue2} does NOT equal {0.3m}, it equals {decimalValue1 + decimalValue2}");
}//decimal은 10진수로 정확히 표현 가능, 고정소수점


#endregion

#region 특수 실수 값(Special real number values)

Console.WriteLine("특수 실수 값");
Console.WriteLine($"double.Epsilon: {double.Epsilon}"); //double에서 표현할 수 있는 가장 작은 양의 수
Console.WriteLine($"double.Epsilon to 324 decimal places: {double.Epsilon:N324}");
Console.WriteLine($"double.Epsilon to 350 decimal places: {double.Epsilon:N350}");


Console.WriteLine("열 너비 설정 및 정렬: 좌측 정렬 음수, 우측 정렬 양수");
const int col1 = 37; //열 너비를 37로 설정하여 "Expression" 열의 내용을 왼쪽 정렬, "Value" 열의 내용을 오른쪽 정렬
const int col2 = 6;
string line = new string('-', col1 + col2 + 3);
Console.WriteLine(line);
Console.WriteLine($"{"Expression",-col1} | {"Value",col2}");
Console.WriteLine(line);
Console.WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}"); //Not a Number, 수학적으로 정의되지 않은 값, 예: 0.0 / 0.0
Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}"); //양의 무한대, 예: 3.0 / 0.0
Console.WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}"); //음의 무한대, 예: -3.0 / 0.0
Console.WriteLine(line);
Console.WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
Console.WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity,col2}");
Console.WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
Console.WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}"); //부동 소수점에서는 음의 0.0도 존재, 결과는 -0.0
Console.WriteLine($"{"0.0m / -3.0m",-col1} | {0.0m / -3.0m,col2}"); //고정 소수점에서는 음의 0.0이 존재하지 않음, 결과는 0.0
Console.WriteLine(line);
#endregion

#region 새로운 숫자 타입(Half, Int128), 안전하지 않은 코드(unsafe)
unsafe //unsafe 키워드를 사용하여 안전하지 않은 코드 블록을 선언, csproj 파일에서 <AllowUnsafeBlocks>true</AllowUnsafeBlocks> 설정 필요
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}."); //float의 절반 크기
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}."); //아주 큰 정수까지 지원
}

#endregion