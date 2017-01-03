package listsorfe.ru.myapplication;

import android.content.Intent;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Main3Activity extends AppCompatActivity {

    public static final int DURATION = 15;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main3);

        final TextView _tv = (TextView) findViewById( R.id.textView31 );
        new CountDownTimer(DURATION * 1000, 1000) {

            public void onTick(long millisUntilFinished) {
                ((TextView) findViewById( R.id.textView32 )).setText("Дыхательное упражнение:");
                _tv.setText("Осталось: " + new SimpleDateFormat("mm:ss").format(new Date( millisUntilFinished)));
            }

            public void onFinish() {
                Intent intent = new Intent(Main3Activity.this, MainActivity.class);
                startActivity(intent);
            }
        }.start();
    }
}
