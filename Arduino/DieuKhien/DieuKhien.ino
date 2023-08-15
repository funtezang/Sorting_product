#include <Servo.h>

// Khai báo chân kết nối với relay
const int relayPin = 5;

// Khai báo chân kết nối với cảm biến màu sắc TCS3200
const int S0 = 6;
const int S1 = 7;
const int S2 = 8;
const int S3 = 9;
const int OUT = 10;

// Khai báo chân kết nối với động cơ Servo
const int servoPin1 = 4;
const int servoPin = 3;

// Khởi tạo đối tượng Servo
Servo servo;
Servo servo1;

// Khai báo biến lưu trữ giá trị đọc từ cảm biến màu sắc
int redValue = 0;
int greenValue = 0;
int blueValue = 0;

// Dải giá trị cho màu đỏ
const int RED_LOWER_THRESHOLD = 1700;
const int RED_UPPER_THRESHOLD = 3700;
const int GREEN_LOWER_THRESHOLD = 5000;
const int GREEN_UPPER_THRESHOLD = 7000;
const int BLUE_LOWER_THRESHOLD = 5000;
const int BLUE_UPPER_THRESHOLD = 7000;

// Dải giá trị cho màu xanh lam
const int RED_LOWER_THRESHOLD1 = 6000;
const int RED_UPPER_THRESHOLD1 = 8000;
const int GREEN_LOWER_THRESHOLD1 = 4300;
const int GREEN_UPPER_THRESHOLD1 = 6300;
const int BLUE_LOWER_THRESHOLD1 = 3200;
const int BLUE_UPPER_THRESHOLD1 = 5200;

// Hàm đọc giá trị từ cảm biến màu sắc
void readColor() {
  // Chọn chế độ tần số không phân giải
  digitalWrite(S0, LOW);
  digitalWrite(S1, HIGH);

  // Đọc giá trị màu đỏ
  digitalWrite(S2, LOW);
  digitalWrite(S3, LOW);
  redValue = pulseIn(OUT, digitalRead(OUT) == HIGH ? LOW : HIGH);

  // Đọc giá trị màu xanh lá cây
  digitalWrite(S2, HIGH);
  digitalWrite(S3, HIGH);
  greenValue = pulseIn(OUT, digitalRead(OUT) == HIGH ? LOW : HIGH);

  // Đọc giá trị màu xanh dương
  digitalWrite(S2, LOW);
  digitalWrite(S3, HIGH);
  blueValue = pulseIn(OUT, digitalRead(OUT) == HIGH ? LOW : HIGH);
}

// Hàm phân loại màu sắc và thực hiện hành động tương ứng
void classifyColor() {
  // Phân loại màu đỏ
  if (redValue >= RED_LOWER_THRESHOLD && redValue <= RED_UPPER_THRESHOLD && greenValue >= GREEN_LOWER_THRESHOLD && greenValue <= GREEN_UPPER_THRESHOLD && blueValue >= BLUE_LOWER_THRESHOLD && blueValue <= BLUE_UPPER_THRESHOLD) {
    // Màu sắc nằm trong dải giá trị cho màu đỏ, xanh lá cây và xanh dương
    // Thực hiện hành động tương ứng
    delay(3400);     // Đợi 3.4 giây
    servo.write(0);  // Góc 0 độ
    delay(400);      // Đợi 0.4 giây
    servo.write(90);
  }  // Phân loại màu xanh lam
  else if (redValue >= RED_LOWER_THRESHOLD1 && redValue <= RED_UPPER_THRESHOLD1 && greenValue >= GREEN_LOWER_THRESHOLD1 && greenValue <= GREEN_UPPER_THRESHOLD1 && blueValue >= BLUE_LOWER_THRESHOLD1 && blueValue <= BLUE_UPPER_THRESHOLD1) {
    // Màu sắc nằm trong dải giá trị cho màu đỏ, xanh lá cây và xanh dương
    // Thực hiện hành động tương ứng
    delay(1700);       // Đợi 1.75 giây
    servo1.write(0);   // Góc 0 độ
    delay(400);        // Đợi 0.4 giây
    servo1.write(90);  // Góc 90 độ
  } else {
    // Không phân loại được màu đỏ và xanh
    delay(500);  // Đợi 0.5 giây
  }
}

void setup() {
  // Cài đặt chân kết nối với cảm biến màu sắc TCS3200
  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  pinMode(OUT, INPUT);

  // Cài đặt chân kết nối với động cơ Servo
  servo.attach(servoPin);
  servo1.attach(servoPin1);

  // Cài đặt chân kết nối relay
  pinMode(relayPin, OUTPUT);

  // Khởi tạo Serial để gửi giá trị đọc được từ cảm biến
  Serial.begin(9600);
}



void loop() {

  String dulieu = "";
  while (Serial.available() > 0) {
    char c = Serial.read();
    dulieu += c;
    delay(5);
  }
  dulieu.trim();

  // Bật B1, Tắt T1;

  if (dulieu == "B1") {
    digitalWrite(relayPin, HIGH);  // Bật băng tải bằng việc bật relay
  }

  if (dulieu == "T1") {
    digitalWrite(relayPin, LOW);  // Tắt băng tải bằng việc tắt relay
  }

  if (dulieu == "B1") {
    // Đọc giá trị từ cảm biến màu sắc
    readColor();
    // In giá trị đọc được lên Serial Monitor
    Serial.print("Red: ");
    Serial.print(redValue);
    Serial.print("  Green: ");
    Serial.print(greenValue);
    Serial.print("  Blue: ");
    Serial.println(blueValue);

    // Phân loại màu sắc và thực hiện hành động
    classifyColor();
  }
}