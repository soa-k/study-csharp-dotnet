// 각 변수는 지역 변수이므로 camel Case로 작성
using System.Text;

char firstLetter = 'H'; // 글자 하나(2 byte)를 저장할 수 있는 char 타입의 변수 firstLetter를 선언, 문자 'H'로 초기화
string bookTitle = "Harry Potter and the Sorcerer's Stone"; // 여러 개의 문자를 저장할 수 있는 string 타입의 변수 bookTitle을 선언, "~"로 초기화
Console.OutputEncoding = Encoding.UTF8; // Console.OutputEncoding을 UTF-8로 설정하여 콘솔에서 유니코드 문자(이모지 포함)를 올바르게 표시
string grinningEmoji = char.ConvertFromUtf32(0x1F600); // Unicode 코드 포인트 U+1F600은 😀 이모지에 해당
Console.WriteLine($"{bookTitle} starts with the letter {firstLetter}. {grinningEmoji}"); //기본 도구를 윈도우 터미널로 변경해야 정상 작동(옵션-디버깅-콘솔(터미널) 설정)




//이스케이프 시퀀스(Escape Sequence): 줄 바꿈을 \n, 탭 \t 등
// C#에서는 '\e' 이스케이프는 지원되지 않으므로 유니코드로 대체
char esc = '\u001B'; // ESC를 의미(제어 문자, ASCII 27)
                     //축자 리터럴(Verbatim Literal): @ 기호를 사용하여 문자열 내의 이스케이프 시퀀스를 무시
string filePath = @"C:\televisions\sony\bravia.txt"; // 백슬래시를 그대로 문자열로 사용
//원시 문자열 리터럴(Raw String Literal): """로 시작하여 """로 끝나는 문자열로, 줄 바꿈과 들여쓰기를 그대로 유지
string xml = """             
                 
                 내가 타이핑한 그대로 저장해줌
                 줄 바꿈 등 모두 그대로 유지
                 긴 글을 복사하여 넣을 때 유용
                 /t/e @*!@★☞이와 같이 특수문자도 그대로 저장
                 """;//닫는 따옴표 """의 위치에 맞추어 들여쓰기 유지
//보간된 원시 문자열 리터럴(Interpolated Raw String Literal): $$"""로 시작하여 """로 끝나는 문자열로, 보간과 원시 문자열의 기능을 모두 제공
//중괄호가 3개인 경우 바깥 중괄호는 Literal Character, 안쪽 중괄호는 변수 참조
string json = $$"""
                  {{Environment.NewLine}}{
                        "name": "{{bookTitle}}",
                        "firstLetter": "{{{firstLetter}}}",
                        "emoji": "{{grinningEmoji}}"
                  }
                  """;
Console.WriteLine((int)esc); //\e는 제어 문자(Control Character)로, ASCII 코드 27에 해당
Console.WriteLine($"The file path is {filePath}.");
Console.WriteLine($" The XML content is: {xml}.");
Console.WriteLine($"The JSON content is: {json}.");
