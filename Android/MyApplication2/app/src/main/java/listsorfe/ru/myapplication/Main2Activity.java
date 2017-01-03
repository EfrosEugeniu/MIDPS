package listsorfe.ru.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.widget.TextView;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Main2Activity extends AppCompatActivity {

    public static final int DURATION = 10;
    Integer counter = 3;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        runCountDownTimer();
    }

    @NonNull
    private void runCountDownTimer() {
        final TextView _tv = (TextView) findViewById( R.id.textView );
        new CountDownTimer(DURATION *1000, 1000) {

            public void onTick(long millisUntilFinished) {
                ((TextView) findViewById( R.id.textView2 )).setText(4 - counter + "-е упражнение");
                _tv.setText("Осталось: " + new SimpleDateFormat("mm:ss").format(new Date( millisUntilFinished)));
            }

            public void onFinish() {
                if (counter > 0) {
                    runCountDownTimer();
                    counter--;
                } else {
                    Intent intent = new Intent(Main2Activity.this, Main3Activity.class);
                    startActivity(intent);
                }
            }
        }.start();
    }
}
