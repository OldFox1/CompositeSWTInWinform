package ForStackOverflow;

import java.util.Scanner;

import org.eclipse.swt.SWT;
import org.eclipse.swt.events.KeyEvent;
import org.eclipse.swt.events.KeyListener;
import org.eclipse.swt.events.ModifyEvent;
import org.eclipse.swt.events.ModifyListener;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Event;
import org.eclipse.swt.widgets.Listener;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.swt.widgets.Text;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.omg.CORBA.Environment;
import org.eclipse.swt.custom.StyledText;

public class SimpleStdWriter extends Shell {
	private Text messageText;
	Button sendButton;
	private StyledText communicationText;
	/**
	 * Create the composite.
	 * @param parent
	 * @param style
	 */
	public SimpleStdWriter(Display display) {
		super(display,  SWT.TITLE | SWT.CLOSE);
		setSize(330, 303);
		
		messageText = new Text(this, SWT.BORDER);
		messageText.setBounds(0, 251, 243, 23);
		
		sendButton = new Button(this, SWT.NONE);
		sendButton.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent arg0) {
				
				String msg = messageText.getText();
				messageText.setText("");
				
				writeMessage(msg);
				
			}
		});
		
		sendButton.setBounds(249, 251, 75, 23);
		sendButton.setText("Send");
		
		communicationText = new StyledText(this, SWT.BORDER);
		communicationText.setBounds(0, 0, 324, 245);
		
		Thread t=new Thread(new Runnable() {
			
			String msg;
			
			public void run() {
				
				Scanner reader = new Scanner(System.in);

				while(true)
				{
					msg = reader.nextLine();
					
					if(msg == null)
						return;
					
					Display.getDefault().syncExec(new Runnable() {
						
						@Override
						public void run() {
							communicationText.append("Recived:" + msg+"\n");
						}
					});
				}
			}
		});
		
		t.start();

	}
	
	private void writeMessage(String msg)
	{
		System.out.println(msg);
		
		communicationText.append("Send:" + msg + "\n");
	}
	
	public static void main(String args[]) {
	
		Display display = Display.getDefault();
		
		SimpleStdWriter view = new SimpleStdWriter(display);
		
		view.open();
        view.layout();
        while (!view.isDisposed()) {
            if (!display.readAndDispatch()) {
                display.sleep();
            }
        }
	}

	@Override
	protected void checkSubclass() {
		// Disable the check that prevents subclassing of SWT components
	}
}
